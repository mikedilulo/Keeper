import Vue from "vue";
import Router from "vue-router";
// @ts-ignore
import Login from "./views/Login.vue";
// @ts-ignore
import Dashboard from "./views/Dashboard.vue";
import { authGuard } from "@bcwdev/auth0-vue";

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: "/",
      name: "login",
      component: Login
    },
    {
      path: "/dashboard",
      name: "dashboard",
      component: Dashboard,
      beforeEnter: authGuard
    }
  ]
});
