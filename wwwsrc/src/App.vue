<template>
  <div id="app">
    <!-- <loginbar /> -->
    <router-view />
  </div>
</template>

<script>
import loginbar from "@/components/LoginNavbar.vue";
import { onAuth } from "@bcwdev/auth0-vue";
export default {
  name: "App",
  async beforeCreate() {
    await onAuth();
    this.$store.dispatch("setBearer", this.$auth.bearer);
  },
  components: {
    loginbar
  }
};
</script>

<style>
</style>
