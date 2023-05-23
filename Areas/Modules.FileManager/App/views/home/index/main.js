import Vue from 'vue'
import HelloWorld from "./HelloWorld.vue";

import '../../../utils/app-init.js';

const app = new Vue({
  el: '#kietapp',
  render: h => h(HelloWorld)
})
