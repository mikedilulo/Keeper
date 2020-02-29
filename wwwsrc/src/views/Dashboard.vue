<template>
  <div class="dashboard">
    <homenav />
    <div class="dashboardkeeps container-fluid">
      <div class="row">
        <div class="col-md-6 d-flex inline">
          <div v-for="keep in publicKeeps" :key="keep.id">
            <keepcomponent :keepData="keep" />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import keepcomponent from "@/components/KeepComponent.vue";
import homenav from "@/components/HomeNavbar.vue";
export default {
  name: "dashboard",
  mounted() {
    this.$store.dispatch("getKeeps");
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
