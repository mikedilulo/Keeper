<template>
  <div class="privatekeep container-fluid pr-0 pl-0">
    <homenav />
    <div v-for="keep in privateKeeps" :key="keep.id">
      <privatekeepcomponent :keepData="keep" />
    </div>
  </div>
</template>

<script>
import privatekeepcomponent from "@/components/PrivateKeepComponent.vue";
import homenav from "@/components/HomeNavbar.vue";
export default {
  name: "dashboard",
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