<template>
  <div class="privatekeepdetails container-fluid pr-0 pl-0">
    <keepdetailnav />
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-5 mt-5">
          <img :src="activePrivateKeep.img" class="latest-card image" alt />
          <div class="d-flex justify-content-between">
            <button class="btn btn-dark mt-5">
              <i class="fas fa-share-square mr-3"></i>Share Keep
            </button>
            <button class="btn btn-dark mt-5">
              <i class="fas fa-pencil-alt mr-3"></i>Edit Keep
            </button>
          </div>
        </div>
        <div class="col-md-5 mt-1">
          <h5 class="publickeepinfo ml-5 mb-4">
            Keep ID:
            <span class="text-danger">{{activePrivateKeep.id}}</span>
          </h5>
          <h5 class="publickeepinfo ml-5 mb-4">
            Keep Created By:
            <span class="text-danger">{{activePrivateKeep.createdBy}}</span>
          </h5>
          <h5 class="ml-5 mb-4">
            Keep Name:
            <span class="text-danger">{{activePrivateKeep.name}}</span>
          </h5>
          <h5 class="ml-5 mb-4">
            Keep Description:
            <span class="text-danger">{{activePrivateKeep.description}}</span>
          </h5>
          <h5 class="ml-5 mb-4">
            Viewed by Users:
            <span class="text-danger">{{activePrivateKeep.views}}</span>
          </h5>
          <h5 class="ml-5 mb-4">
            Stored in Vault:
            <span class="text-danger">{{activePrivateKeep.keeps}}</span>
          </h5>
          <h5 class="ml-5">
            Shared with Users:
            <span class="text-danger">{{activePrivateKeep.shares}}</span>
          </h5>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import keepdetailnav from "@/components/KeepDetailNavbar.vue";
export default {
  name: "privatekeepdetails",
  props: ["keepData"],
  mounted() {
    this.$store.dispatch("getPrivateKeepById", this.$route.params.id);
  },
  computed: {
    activePrivateKeep() {
      return this.$store.state.activePrivateKeep;
    }
  },
  components: {
    keepdetailnav
  }
};
</script>

<style>
.latest-card {
  border-radius: 10px;
  max-width: 100%;
  max-height: 100%;
  position: relative;
}
.image {
  z-index: -1;
  max-width: 100%;
  max-height: 100%;
  position: relative;
}
.publickeepinfo {
  margin-top: 75px;
}
</style>