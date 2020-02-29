<template>
  <div class="dashboard">
    <homenav />
    <div class="dashboardkeeps container-fluid">
      <div class="row">
        <div class="col-md-12">
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
  computed: {
    publicKeeps() {
      this.$store.state.publicKeeps;
    }
  },
  components: {
    homenav,
    keepcomponent
  }
};
</script>

<style></style>
