<template>
  <div class="privatekeepcomponent container-fluid">
    <div class="row">
      <div class="col-md-2 mb-5 mt-5">
        <div class="latest-card">
          <div class="card-body p-0">
            <div class="dropdown">
              <button
                class="btn btn-light dropdown-toggle d-flex justify-content-end ml-1"
                type="button"
                id="dropdownMenuButton"
                data-toggle="dropdown"
                aria-haspopup="true"
                aria-expanded="false"
              ></button>
              <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                <div v-for="vault in vaults" :key="vault.id">
                  <button class="dropdown-item" @click="addKeepToVault(vault.id)">{{vault.name}}</button>
                </div>
              </div>
            </div>
            <img :src="keepData.img" class="latest-card image" alt />
            <dd class="d-flex justify-content-between">
              <router-link :to="{name: 'privateKeepDetails', params: {id: keepData.id}}">
                <button
                  type="button"
                  @click="privateKeepViews(keepData)"
                  class="btn btn-dark btn-sm button"
                  data-dismiss="modal"
                >
                  <i class="fas fa-ellipsis-h"></i>
                </button>
              </router-link>
              <button
                type="submit"
                class="btn btn-dark btn-sm button"
                @click="deletePrivateKeep(keepData.id)"
              >
                <i class="fas fa-trash"></i>
              </button>
            </dd>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import vault from "@/components/VaultComponent.vue";
export default {
  name: "privatekeepcomponent",
  props: ["keepData"],
  methods: {
    deletePrivateKeep(id) {
      this.$store.dispatch("deletePrivateKeep", id);
    },
    setActivePrivateKeep(id) {
      this.$store.dispatch("getPrivateKeepById", id);
    },
    privateKeepViews(privateKeep) {
      this.keepData.views++;
      this.$store.dispatch("editPrivateKeep", privateKeep);
    },
    addKeepToVault(id) {
      this.$store.dispatch("createVaultKeep", {
        vaultId: id,
        keepId: this.keepData.id
      });
    },
    addKeepToVault(privateKeep) {
      this.keepData.keeps++;
      this.$store.dispatch("editPrivateKeep", privateKeep);
    }
  },
  computed: {
    vaults() {
      return this.$store.state.vaults;
    }
  },
  components: {
    vault
  }
};
</script>

<style>
.latest-card {
  border-radius: 10px;
  max-width: 100%;
  max-height: 100%;
}
.button {
  display: none;
  z-index: 1;
}
.latest-card:hover .button {
  display: block;
}
.dropdown {
  position: absolute;
}
#dropdownMenuButton {
  min-width: 90%;
  min-height: 100%;
}
.dropdown {
  display: none;
}
.latest-card:hover .dropdown {
  display: block;
}
.card-body {
  min-height: 100%;
}
.dropbtn,
.sub-dropbtn {
  background-color: transparent;
  cursor: pointer;
  border: none;
}
.image {
  z-index: -1;
  max-width: 100%;
  max-height: 100%;
  position: absolute;
}
</style>