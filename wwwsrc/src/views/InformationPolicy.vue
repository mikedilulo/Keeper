<template>
  <div class="informationpolicy container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="informationpolicies container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="text-light d-flex justify-content-center mt-5">Keeper Policy</h1>
          <p
            class="text-light d-flex justify-content-center mt-3"
          >Here at Keeper we frown upon anything that goes against the policy when using this site. Please take the time to read the cards below. If you have any questions, please send an email on the Contact Us page.</p>
        </div>
      </div>
    </div>
    <div class="middle container-fluid">
      <div class="row">
        <div class="col-md-12">
          <policycard />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import aboutnav from "@/components/AboutNavbar.vue";
import policycard from "@/components/InformationCard.vue";
export default {
  name: "informationpolicy",
  components: {
    aboutnav,
    policycard
  }
};
</script>

<style>
.informationpolicies {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1450101499163-c8848c66ca85?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-top: 80px;
  padding-bottom: 80px;
}
</style>