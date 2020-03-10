<template>
  <div class="home container-fluid">
    <div class="row">
      <div class="col-md-12 p-0">
        <homenav />
        <h1 class="d-flex justify-content-center mt-3 mb-3">Welcome to Keeper!</h1>
      </div>
    </div>
    <div class="row">
      <div class="col-md-4">
        <div v-for="keep in publicKeeps" :key="keep.id">
          <keepcomponent :keepData="keep" />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import keepcomponent from "@/components/KeepComponent.vue";
import homenav from "@/components/HomeNavbar.vue";
export default {
  name: "home",
  mounted() {
    this.$store.dispatch("getPublicKeeps");
  },
  components: {
    homenav,
    keepcomponent
  },
  computed: {
    user() {
      return this.$store.state.user;
    },
    publicKeeps() {
      return this.$store.state.publicKeeps;
    }
  },
  methods: {
    logout() {
      this.$store.dispatch("logout");
    }
  }
};
</script>
