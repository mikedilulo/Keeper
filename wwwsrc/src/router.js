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
// @ts-ignore
import Private from "./views/PrivateKeep.vue";
// @ts-ignore
import PublicKeepDetails from "./views/PublicKeepDetails.vue";
// @ts-ignore
import PrivateKeepDetails from "./views/PrivateKeepDetails.vue";
// @ts-ignore
import InformationUsers from "./views/InformationUsers.vue";
// @ts-ignore
import InformationLegal from "./views/InformationLegal.vue";
// @ts-ignore
import InformationPolicy from "./views/InformationPolicy.vue";
// @ts-ignore
import InformationHottestKeeps from "./views/InformationHottestKeeps.vue";
// @ts-ignore
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
    },
    {
      path: "/private",
      name: "private",
      component: Private
    },
    {
      path: "/public/:id",
      name: "publicKeepDetails",
      component: PublicKeepDetails
    },
    {
      path: "/private/:id",
      name: "privateKeepDetails",
      component: PrivateKeepDetails
    },
    {
      path: "/information/users",
      name: "informationuser",
      component: InformationUsers
    },
    {
      path: "/information/legal",
      name: "informationlegal",
      component: InformationLegal
    },
    {
      path: "/information/policy",
      name: "informationpolicy",
      component: InformationPolicy
    },
    {
      path: "/information/hottestkeeps",
      name: "informationhottestkeeps",
      component: InformationHottestKeeps
    }
  ]
});
