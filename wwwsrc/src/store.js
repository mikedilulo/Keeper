import Vue from "vue";
import Vuex from "vuex";
import Axios from "axios";
import router from "./router";

Vue.use(Vuex);

let baseUrl = location.host.includes("localhost")
  ? "https://localhost:5001/"
  : "https://keepere.herokuapp.com/";

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
});

export default new Vuex.Store({
  state: {
    publicKeeps: [],
    privateKeeps: [],
    vaults: [],
    vaultKeeps: [],
    activePublicKeep: {},
    activePrivateKeep: {},
    activeVault: {}
  },
  mutations: {
    // #region KEEP MUTATIONS
    setPublicKeeps(state, data) {
      state.publicKeeps = data;
    },
    setPrivateKeeps(state, data) {
      state.privateKeeps = data;
    },
    createPublicKeep(state, data) {
      state.publicKeeps.push(data);
    },
    createPrivateKeep(state, data) {
      state.privateKeeps.push(data);
    },
    setPublicActiveKeep(state, keep) {
      state.activePublicKeep = keep;
    },
    setPrivateActiveKeep(state, keep) {
      state.activePrivateKeep = keep;
    },
    // #endregion
    // #region VAULTS MUTATIONS
    setVaults(state, data) {
      state.vaults = data;
    },
    createVault(state, data) {
      state.vaults.push(data);
    },
    setActiveVault(state, vault) {
      state.activeVault = vault;
    },
    // #endregion
    // #region VAULTKEEPS MUTATIONS
    createVaultKeep(state, data) {
      state.vaultKeeps.push(data);
    },
    setVaultKeep(state, vaultKeeps) {
      state.vaultKeeps = vaultKeeps;
    }
    // #endregion
  },
  actions: {
    // #region BEARER
    setBearer({}, bearer) {
      api.defaults.headers.authorization = bearer;
    },
    resetBearer() {
      api.defaults.headers.authorization = "";
    },
    // #endregion
    // #region KEEPS
    async getPublicKeeps({ commit, dispatch }) {
      try {
        let res = await api.get("keeps/public");
        commit("setPublicKeeps", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async getPrivateKeeps({ commit, dispatch }) {
      try {
        let res = await api.get("keeps/private");
        commit("setPrivateKeeps", res.data);
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
    },
    async createPrivateKeep({ commit, dispatch }, payload) {
      try {
        let res = await api.post("keeps", payload);
        commit("createPrivateKeep", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async deletePublicKeep({ commit, dispatch }, id) {
      try {
        let res = await api.delete("keeps/public/" + id);
        dispatch("getPublicKeeps");
      } catch (error) {
        console.error(error);
      }
    },
    async deletePrivateKeep({ commit, dispatch }, id) {
      try {
        let res = await api.delete("keeps/private/" + id);
        dispatch("getPrivateKeeps");
      } catch (error) {
        console.error(error);
      }
    },
    async getPublicKeepById({ commit, dispatch }, id) {
      try {
        let res = await api.get("keeps/public/" + id);
        commit("setPublicActiveKeep", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async getPrivateKeepById({ commit, dispatch }, id) {
      try {
        let res = await api.get("keeps/private/" + id);
        commit("setPrivateActiveKeep", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async editPublicKeep({ commit, dispatch }, publicKeep) {
      try {
        let res = await api.put("keeps/public/" + publicKeep.id, publicKeep);
        dispatch("getPublicKeeps");
      } catch (error) {
        console.error(error);
      }
    },
    async editPrivateKeep({ commit, dispatch }, privateKeep) {
      try {
        let res = await api.put("keeps/private/" + privateKeep.id, privateKeep);
        dispatch("getPrivateKeeps");
      } catch (error) {
        console.error(error);
      }
    },
    // #endregion
    // #region VAULTS
    async getAllVaults({ commit, dispatch }) {
      try {
        let res = await api.get("vaults/private");
        commit("setVaults", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async createVault({ commit, dispatch }, payload) {
      try {
        let res = await api.post("vaults", payload);
        commit("createVault", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async getVaultById({ commit, dispatch }, id) {
      try {
        let res = await api.get("vaults/private/" + id);
        commit("setActiveVault", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async deleteVault({ commit, dispatch }, id) {
      try {
        let res = await api.delete("vaults/private/" + id);
        dispatch("getAllVaults");
      } catch (error) {
        console.error(error);
      }
    },
    async editPrivateVault({ commit, dispatch }, vault) {
      try {
        let res = await api.put("vaults/private/" + vault.id, vault);
        dispatch("getAllVaults");
      } catch (error) {
        console.error(error);
      }
    },
    // #endregion
    // #region VAULTKEEPS
    async createVaultKeep({ commit, dispatch }, payload) {
      try {
        let res = await api.post("vaultkeeps", payload);
        commit("createVaultKeep", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async getVaultKeepByVaultId({ commit, dispatch }, vaultId) {
      try {
        let res = await api.get("vaultkeeps/" + vaultId + "/keeps");
        commit("setVaultKeep", res.data);
      } catch (error) {
        console.error(error);
      }
    },
    async deleteVaultKeepByVaultId({ commit, dispatch }, vaultKeep) {
      try {
        let res = await api.delete(
          "vaultkeeps/" + vaultKeep.vaultId + "/keeps/" + vaultKeep.keepId,
          vaultKeep
        );
        dispatch("getVaultKeepByVaultId", vaultKeep.vaultId);
      } catch (error) {
        console.error(error);
      }
    }
    // #endregion
  }
});
