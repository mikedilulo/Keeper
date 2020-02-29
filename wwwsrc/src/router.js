import Vue from "vue";
import Router from "vue-router";
// @ts-ignore
import Login from "./views/Login.vue";
// @ts-ignore
import Home from "./views/Home.vue";
// @ts-ignore
import Dashboard from "./views/Dashboard.vue";
// @ts-ignore
import Suggestion from "./views/Suggestion.vue";
// @ts-ignore
import Subscribe from "./views/Subscribe.vue";
// @ts-ignore
import About from "./views/About.vue";
// @ts-ignore
import Contact from "./views/Contact.vue";
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
    },
    {
      path: "/home",
      name: "home",
      component: Home,
      beforeEnter: authGuard
    },
    {
      path: "/suggestion",
      name: "suggestion",
      component: Suggestion
    },
    {
      path: "/subscribe",
      name: "subscribe",
      component: Subscribe
    },
    {
      path: "/about",
      name: "about",
      component: About
    },
    {
      path: "/contact",
      name: "contact",
      component: Contact
    }
  ]
});
