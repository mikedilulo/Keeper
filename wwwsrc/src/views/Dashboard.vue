<template>
  <div class="dashboard">
    <homenav />
    <div class="dashboardkeeps container-fluid">
      <div class="row">
        <div class="col-md-12">
          <keepcomponent />
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
  components: {
    homenav,
    keepcomponent
  }
};
</script>

<style></style>
