<template>
  <nav class="navbar navbar-expand-lg navbar-light bg-light">
    <router-link class="navbar-brand" :to="{ name: 'home' }">
      <strong>
        <i class="fab fa-korvue heading ml-2 mr-2"></i>
      </strong>
    </router-link>
    <button
      class="navbar-toggler"
      type="button"
      data-toggle="collapse"
      data-target="#navbarText"
      aria-controls="navbarText"
      aria-expanded="false"
      aria-label="Toggle navigation"
    >
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarText">
      <ul class="navbar-nav mr-auto">
        <li class="nav-item home-list ml-2 mr-2 active" :class="{ active: $route.name == 'home' }">
          <router-link :to="{ name: 'home' }" class="nav-link">Keeper-Home</router-link>
        </li>
        <li
          class="nav-item home-list active ml-2 mr-2"
          v-if="$auth.isAuthenticated"
          :class="{ active: $route.name == 'dashboard' }"
        >
          <router-link class="nav-link" :to="{ name: 'dashboard' }">My-Keeper-Dashboard</router-link>
        </li>
        <li class="nav-item home-list active ml-2 mr-2" v-if="this.$route.name == 'dashboard'">
          <router-link class="nav-link" :to="{ name: 'private' }">My-Private-Keeps</router-link>
        </li>
        <li class="nav-item home-list active ml-2 mr-2" v-if="this.$route.name == 'dashboard'">
          <router-link class="nav-link" :to="{ name: 'vaults' }">My-Vaults</router-link>
        </li>
      </ul>
      <button
        v-if="this.$route.name == 'dashboard'"
        class="btn btn-outline-success btn-sm mr-5"
        type="button"
        data-toggle="modal"
        data-target="#modalKeeps"
      >Create Keep</button>
      <button
        v-if="this.$route.name == 'vaults'"
        class="btn btn-outline-primary btn-sm mr-5"
        type="button"
        data-toggle="modal"
        data-target="#modalVaults"
      >Create Vault</button>
      <button class="btn btn-outline-danger btn-sm" @click="logout">Logout</button>
    </div>
    <!-- MODAL FOR KEEPS -->
    <div
      class="modal fade"
      id="modalKeeps"
      tabindex="-1"
      role="dialog"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Create New Keep</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <form>
              <div class="form-group">
                <label for="created-name" class="col-form-label">Created By:</label>
                <input
                  type="text"
                  class="form-control"
                  id="created-name"
                  placeholder="Enter nickname or email"
                  v-model="newKeep.createdBy"
                />
              </div>
              <div class="form-group">
                <label for="keep-name" class="col-form-label">Keep Name:</label>
                <input
                  type="text"
                  class="form-control"
                  id="keep-name"
                  placeholder="Enter Keep Name"
                  v-model="newKeep.name"
                />
              </div>
              <div class="form-group">
                <label for="keep-description" class="col-form-label">Keep Description:</label>
                <input
                  type="text"
                  class="form-control"
                  id="keep-description"
                  placeholder="Enter Keep Description"
                  v-model="newKeep.description"
                />
              </div>
              <div class="form-group">
                <label for="keep-image" class="col-form-label">Keep Image:</label>
                <input
                  type="text"
                  class="form-control"
                  id="keep-image"
                  placeholder="Enter Keep URL"
                  v-model="newKeep.img"
                />
              </div>
              <div class="form-group">
                <input
                  type="checkbox"
                  id="private-keep"
                  name="private-keep"
                  value="isPrivate"
                  class="keepCheckbox ml-1"
                  v-model="newKeep.isPrivate"
                />
                <label for="keep-private" class="col-form-label ml-1">Private Keep</label>
              </div>
              <button type="button" class="btn btn-success" @click="createKeep">Create Keep</button>
            </form>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
          </div>
        </div>
      </div>
    </div>
    <!-- MODAL FOR VAULTS -->
    <div
      class="modal fade"
      id="modalVaults"
      tabindex="-1"
      role="dialog"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Create New Vault</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <form>
              <div class="form-group">
                <label for="vault-name" class="col-form-label">Vault Name:</label>
                <input
                  type="text"
                  class="form-control"
                  id="vault-name"
                  placeholder="Enter Vault Name"
                  v-model="newVault.name"
                />
              </div>
              <div class="form-group">
                <label for="vault-description" class="col-form-label">Vault Description:</label>
                <input
                  type="text"
                  class="form-control"
                  id="vault-description"
                  placeholder="Enter Vault Description"
                  v-model="newVault.description"
                />
              </div>
              <div class="form-group">
                <label for="vault-image" class="col-form-label">Vault Image:</label>
                <input
                  type="text"
                  class="form-control"
                  id="vault-image"
                  placeholder="Enter Vault URL"
                  v-model="newVault.img"
                />
              </div>
              <button type="button" class="btn btn-primary" @click="createVault">Create Vault</button>
            </form>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
          </div>
        </div>
      </div>
    </div>
  </nav>
</template>

<script>
import axios from "axios";
let _api = axios.create({
  baseURL: "https://localhost:5001",
  withCredentials: true
});
export default {
  name: "Navbar",
  data() {
    return {
      newKeep: {
        name: "",
        description: "",
        img: "",
        isPrivate: false,
        views: 0,
        shares: 0,
        keeps: 0,
        createdBy: ""
      },
      newVault: {
        name: "",
        description: "",
        img: "",
        views: 0
      }
    };
  },
  methods: {
    async logout() {
      await this.$auth.logout();
      this.$store.dispatch("resetBearer");
      this.$router.push({ name: "home" });
    },
    createKeep() {
      let newKeep = { ...this.newKeep };
      this.$store.dispatch("createKeep", newKeep);
      if (newKeep.isPrivate.checked) {
        this.$store.dispatch("createPrivateKeep", newKeep);
      }
      this.newKeep = {
        name: "",
        description: "",
        img: "",
        isPrivate: Boolean,
        views: "",
        shares: "",
        keeps: "",
        createdBy: ""
      };
    },
    createVault() {
      let newVault = { ...this.newVault };
      this.$store.dispatch("createVault", newVault);
      this.newVault = {
        name: "",
        description: "",
        img: "",
        views: ""
      };
    }
  }
};
</script>
<style>
.heading {
  font-size: 36px;
}
.home-list {
  font-size: 18px;
}
.keepCheckbox {
  min-height: 20px;
  min-width: 20px;
}
</style>