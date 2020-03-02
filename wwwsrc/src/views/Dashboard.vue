<template>
  <div class="dashboard container-fluid pr-0 pl-0">
    <homenav />
    <div v-for="keep in publicKeeps" :key="keep.id">
      <keepcomponent :keepData="keep" />
    </div>
  </div>
</template>

<script>
import keepcomponent from "@/components/KeepComponent.vue";
import homenav from "@/components/HomeNavbar.vue";
export default {
  name: "dashboard",
  props: ["keepData"],
  mounted() {
    this.$store.dispatch("getPublicKeeps");
  },
  computed: {
    publicKeeps() {
      return this.$store.state.publicKeeps;
    }
  },
  components: {
    homenav,
    keepcomponent
  }
};
</script>

<style></style>
