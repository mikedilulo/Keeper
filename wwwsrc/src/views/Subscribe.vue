<template>
  <div class="subscribe container-fluid beach-image">
    <div class="row">
      <div class="col-md-12">
        <homelink />
        <h1
          class="text-light d-flex justify-content-center mt-5"
        >Whether at home or at the beach, always stay connected.</h1>
        <h1 class="text-light d-flex justify-content-center mb-4">Subscribe with us today</h1>
        <div class="row">
          <div class="col-md-12 d-flex justify-content-center mb-5">
            <subscriptionform />
          </div>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-md-3 mt-5">
        <h5 class="mb-5">Photo From Unsplash</h5>
        <h5 class="text-white mb-3">@2020 Keeper</h5>
      </div>
    </div>
  </div>
</template>

<script>
import subscriptionform from "@/components/SubscriptionForm.vue";
import homelink from "@/components/HomeLinkNavbar.vue";
export default {
  name: "subscribe",
  components: {
    homelink,
    subscriptionform
  }
};
</script>

<style>
.beach-image {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1523906873612-7574ec83f052?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=761&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-left: 0px;
  margin-right: 0px;
}
</style>