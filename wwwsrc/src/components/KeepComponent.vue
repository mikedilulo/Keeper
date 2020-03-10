<template>
  <div class="keepcomponent">
    <div class="col-md-12 ml-2 mb-5 mt-5 p-0 latest-card">
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
        <router-link :to="{name: 'publicKeepDetails', params: {id: keepData.id}}">
          <button
            type="button"
            @click="publicKeepViews(keepData)"
            class="btn btn-dark btn-sm button"
            data-dismiss="modal"
          >
            <i class="fas fa-ellipsis-h"></i>
          </button>
        </router-link>
        <button type="submit" class="btn btn-dark btn-sm button" @click="deleteKeep(keepData.id)">
          <i class="fas fa-trash"></i>
        </button>
        <button
          v-if="this.$route.name == `vaultdetails`"
          class="btn btn-warning"
          @click="removeKeepFromVault()"
        >RFV</button>
      </dd>
    </div>
  </div>
</template>

<script>
import vault from "@/components/VaultComponent.vue";
export default {
  name: "keepcomponent",
  mounted() {
    this.$store.dispatch("getAllVaults");
  },
  props: ["keepData", "vaultData"],
  methods: {
    removeKeepFromVault() {
      this.$store.dispatch("deleteVaultKeepByVaultId", {
        vaultId: this.$route.params.id,
        keepId: this.keepData.id
      });
    },
    deleteKeep(id) {
      this.$store.dispatch("deletePublicKeep", id);
    },
    setActivePublicKeep(id) {
      this.$store.dispatch("getPublicKeepById", id);
    },
    publicKeepViews(publicKeep) {
      this.keepData.views++;
      this.$store.dispatch("editPublicKeep", publicKeep);
    },
    addKeepToVault(id) {
      this.$store.dispatch("createVaultKeep", {
        vaultId: id,
        keepId: this.keepData.id
      });
    },
    addKeepToVault(publicKeep) {
      this.keepData.keeps++;
      this.$store.dispatch("editPublicKeep", publicKeep);
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
.dropbtn,
.sub-dropbtn {
  background-color: transparent;
  cursor: pointer;
  border: none;
}
</style>