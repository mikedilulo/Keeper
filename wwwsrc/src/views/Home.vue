<template>
  <div class="home container-fluid">
    <div class="row">
      <div class="col-md-12 p-0">
        <homenav />
      </div>
    </div>
  </div>
</template>

<script>
import homenav from "@/components/HomeNavbar.vue";
export default {
  name: "home",
  components: {
    homenav
  },
  computed: {
    user() {
      return this.$store.state.user;
    }
  },
  methods: {
    logout() {
      this.$store.dispatch("logout");
    }
  }
};
</script>
