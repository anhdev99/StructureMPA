import Vue from 'vue'
import VueRouter from 'vue-router';
import App from './App.vue'
import router from "./router/index";

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue-next/dist/bootstrap-vue-next.css'

import store from "./state/store";
import "./design/app.scss";

Vue.component('default-layout', () => import(/* webpackChunkName: "layout-container" */ './components/layout/DefaultLayout.vue'));
Vue.use(VueRouter);

new Vue({
    router,
    store,
    render: h => h(App),
}).$mount('#app')
