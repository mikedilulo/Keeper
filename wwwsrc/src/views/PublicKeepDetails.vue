<template>
  <div class="publickeepdetails container-fluid pr-0 pl-0">
    <keepdetailnav />
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-5 mt-5">
          <img :src="activePublicKeep.img" class="latest-card image" alt />
          <div class="d-flex justify-content-between">
            <button class="btn btn-dark mt-5">
              <i class="fas fa-share-square mr-3"></i>Share Keep
            </button>
            <button
              class="btn btn-dark mt-5"
              data-toggle="modal"
              data-target="#editedPublicKeepModal"
            >
              <i class="fas fa-pencil-alt mr-3"></i>Edit Keep
            </button>
          </div>
        </div>
        <div class="col-md-5 mt-1">
          <h5 class="publickeepinfo ml-5 mb-4">
            Keep ID:
            <span class="text-danger">{{activePublicKeep.id}}</span>
          </h5>
          <h5 class="publickeepinfo ml-5 mb-4">
            Keep Created By:
            <span class="text-danger">{{activePublicKeep.createdBy}}</span>
          </h5>
          <h5 class="ml-5 mb-4">
            Keep Name:
            <span class="text-danger">{{activePublicKeep.name}}</span>
          </h5>
          <h5 class="ml-5 mb-4">
            Keep Description:
            <span class="text-danger">{{activePublicKeep.description}}</span>
          </h5>
          <h5 class="ml-5 mb-4">
            Viewed by Users:
            <span class="text-danger">{{activePublicKeep.views}}</span>
          </h5>
          <h5 class="ml-5 mb-4">
            Stored in Vault:
            <span class="text-danger">{{activePublicKeep.keeps}}</span>
          </h5>
          <h5 class="ml-5">
            Shared with Users:
            <span class="text-danger">{{activePublicKeep.shares}}</span>
          </h5>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import keepdetailnav from "@/components/KeepDetailNavbar.vue";
export default {
  name: "publickeepdetails",
  props: ["keepData"],
  mounted() {
    this.$store.dispatch("getPublicKeepById", this.$route.params.id);
  },
  computed: {
    activePublicKeep() {
      return this.$store.state.activePublicKeep;
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