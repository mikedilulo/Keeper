<template>
  <div class="suggestion container-fluid box-image">
    <div class="row">
      <div class="col-md-12 mb-4">
        <homelink />
        <h1
          class="text-light d-flex justify-content-center mt-5"
        >Have a great way to make this better?</h1>
        <h1
          class="text-light d-flex justify-content-center"
        >Send us an email with your suggestion today</h1>
        <div class="row">
          <div class="col-md-12 d-flex justify-content-center">
            <contactform />
          </div>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-md-3 mb-3">
        <h5 class="text-white">@2020 Keeper</h5>
      </div>
    </div>
  </div>
</template>

<script>
import contactform from "@/components/ContactForm.vue";
import homelink from "@/components/HomeLinkNavbar.vue";
export default {
  name: "suggestion",
  components: {
    homelink,
    contactform
  }
};
</script>

<style>
.box-image {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1549315393-aeac60e09d29?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-left: 0px;
  margin-right: 0px;
}
</style>