import Vue from "vue";
import Vuex from "vuex";
import Axios from "axios";
import router from "./router";

Vue.use(Vuex);

let baseUrl = location.host.includes("localhost")
  ? "https://localhost:5001/"
  : "/";

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
});

export default new Vuex.Store({
  state: {
    publicKeeps: [],
    privateKeeps: []
  },
  mutations: {
    createPublicKeep(state, data) {
      state.publicKeeps.unshift(data);
    },
    createPrivateKeep(state, data) {
      state.privateKeeps.unshift(data);
    },
    setKeeps(state, data) {
      state.publicKeeps = data;
    }
  },
  actions: {
    setBearer({}, bearer) {
      api.defaults.headers.authorization = bearer;
    },
    resetBearer() {
      api.defaults.headers.authorization = "";
    },
    // #region KEEPS
    async getKeeps({ commit, dispatch }) {
      try {
        let res = await api.get("keeps");
        commit("setKeeps", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async createPrivateKeep({ commit, dispatch }, payload) {
      try {
        let res = await api.post("keeps", payload);
        commit("createPrivateKeep", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async createKeep({ commit, dispatch }, payload) {
      try {
        let res = await api.post("keeps", payload);
        commit("createPublicKeep", res.data);
      } catch (error) {
        console.error(error);
      }
    }
    // #endregion
  }
});
