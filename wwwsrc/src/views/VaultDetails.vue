<template>
  <div class="vaultdetails">
    <keepdetailnav />
    <div class="vaultdetails container-fluid">
      <div class="row">
        <div class="col-md-4">
          <div v-for="keep in vaultKeeps" :key="keep.id">
            <keepcomponent :keepData="keep" />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import keepcomponent from "@/components/KeepComponent.vue";
import keepdetailnav from "@/components/KeepDetailNavbar.vue";
export default {
  name: "vaultdetails",
  props: ["keepData", "vaultData"],
  mounted() {
    this.$store.dispatch("getVaultKeepByVaultId", this.$route.params.id);
  },
  computed: {
    vaultKeeps() {
      return this.$store.state.vaultKeeps;
    }
  },
  components: {
    keepdetailnav,
    keepcomponent
  }
};
</script>

<style>
</style>