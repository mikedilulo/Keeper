<template>
  <div class="vaults container-fluid pr-0 pl-0">
    <homenav />
    <h1 class="d-flex justify-content-center mt-3 mb-3">Your Vaults</h1>
    <div class="vault-render container-fluid">
      <div class="row">
        <div class="col-md-12">
          <div v-for="vault in vaults" :key="vault.id">
            <vaultComponent :vaultData="vault" />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import vaultComponent from "@/components/VaultComponent.vue";
import homenav from "@/components/HomeNavbar.vue";
export default {
  name: "vaults",
  mounted() {
    this.$store.dispatch("getAllVaults");
  },
  props: ["vaultData"],
  components: {
    homenav,
    vaultComponent
  },
  computed: {
    vaults() {
      return this.$store.state.vaults;
    }
  }
};
</script>

<style>
</style>