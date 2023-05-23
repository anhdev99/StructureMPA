import Vue from 'vue'
import VueRouter from 'vue-router';
import App from './App.vue'
import router from "./router/index";
import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue-next/dist/bootstrap-vue-next.css'
// import './assets/styles/style.css'

import store from "./state/store";
import "./design/app.scss";
import "./design/index.scss";
Vue.component('default-layout', () => import(/* webpackChunkName: "layout-container" */ './components/layout/DefaultLayout.vue'));
Vue.use(VueRouter);
Vue.use(BootstrapVue);
new Vue({
    router,
    store,
    render: h => h(App),
}).$mount('#app')
