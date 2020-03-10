<template>
  <div class="privatekeep container-fluid pr-0 pl-0">
    <homenav />
    <h1 class="d-flex justify-content-center mt-3 mb-3">Private Keeps</h1>
    <div v-for="keep in privateKeeps" :key="keep.id">
      <privatekeepcomponent :keepData="keep" />
    </div>
  </div>
</template>

<script>
import privatekeepcomponent from "@/components/PrivateKeepComponent.vue";
import homenav from "@/components/HomeNavbar.vue";
export default {
  name: "private",
  mounted() {
    this.$store.dispatch("getPrivateKeeps");
  },
  computed: {
    privateKeeps() {
      return this.$store.state.privateKeeps;
    }
  },
  components: {
    homenav,
    privatekeepcomponent
  }
};
</script>

<style></style>