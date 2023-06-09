﻿const VueLoaderPlugin = require('vue-loader/lib/plugin');
const glob = require('glob');
const path = require('path');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const CompressionWebpackPlugin = require('compression-webpack-plugin');
const OptimizeCssAssetsPlugin = require('optimize-css-assets-webpack-plugin');

const isProduction = (process.env.NODE_ENV === 'production');
if (isProduction) {
  console.log("Bundling in PRODUCTION mode")
} else {
  console.log("Bundling in DEVELOPMENT mode")
}

const entries = {};
entries['styles'] = path.join(__dirname, 'assets/styles/styles.scss');

const IGNORE_PATHS = ['unused'];

// glob.sync('./views/**/main.js').forEach(path => {
//   const chunk = path.split('./views/')[1].split('/main.js')[0]
//   if (IGNORE_PATHS.every(path => !chunk.includes(path))) {
//     if (!chunk.includes('/')) {
//       entries[chunk] = path
//     } else {
//       const joinChunk = chunk.split('/').join('-')
//       entries[joinChunk] = path
//     }
//   }
// });

module.exports = {
  entry: "./main.js",
  mode: isProduction ? 'production' : 'development',
  output: {
    path: path.resolve(__dirname, '../wwwroot'),
    filename: 'fileManager/js/[name].bundle.js'
  },
  module: {
    rules: [
      {
        test: /\.vue$/,
        loader: 'vue-loader',
      },
      {
        test: /\.(css|s[ac]ss)$/,
        use: [
          'style-loader',
          {loader: 'css-loader', options: {url: false}},
          {
            loader: 'sass-loader',
            options: {
              implementation: require('node-sass')
            }
          }
        ],
        exclude: [
          path.join(__dirname, 'assets/styles/styles.scss')
        ]
      },
      {
        test: /\.(png|jpe?g|gif)$/i,
        type: 'asset/resource',
      },
      {
        test: /\.js$/,
        exclude: /node_modules/,
        use: {
          loader: 'babel-loader',
          options: {
            presets: [
              ['@babel/preset-env', { targets: "defaults" }],
            ]
          }
        },
      },
    ]
  },
  devServer: {
    watchContentBase: true,
    historyApiFallback: true,
    hot: true,
    open: true,
    noInfo: true,
    overlay: true,
    https: false,
    port: 9000,
    proxy: {
      '*': {
        target: 'https://localhost:7264',
        changeOrigin: false,
        secure: false
      }
    },
    contentBase: [path.join(__dirname, '../wwwroot')],
  },
  plugins: [
    new VueLoaderPlugin(),
    new MiniCssExtractPlugin({
      filename: 'fileManager/css/[name].bundle.css'
    }),
  ],
  optimization: {
    runtimeChunk: 'single',
    splitChunks: {
      minSize: 0,
      cacheGroups: {
        core: {
          name: 'core',
          chunks: 'all',
          test: /[\\/]node_modules[\\/](bootstrap-vue|vue|vuelidate|font-awesome|popper.js|portal-vue|process|regenerator-runtime|setimmediate|vue-functional-data-merge)[\\/]/,
          priority: 20,
          enforce: true
        },
        vendor: {
          name: 'vendor',
          chunks: 'all',
          test: /[\\/]node_modules[\\/]/,
          priority: 10,
          enforce: true
        }
      }
    }
  }
}

if (isProduction) {
  module.exports.plugins = (module.exports.plugins || []).concat([
    new CompressionWebpackPlugin(),
    new OptimizeCssAssetsPlugin(),
  ])
}