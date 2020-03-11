<template>
  <div class="informationuser container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="informationusers container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="text-light d-flex justify-content-center mt-5">Keeper Users</h1>
          <p
            class="text-light d-flex justify-content-center mt-3"
          >Connect and share with our many users around the globe. Sign in, or create an account to join the many users of Keeper today!</p>
        </div>
      </div>
    </div>
    <div class="middle container-fluid">
      <div class="row">
        <div class="col-md-12">
          <infocard />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import aboutnav from "@/components/AboutNavbar.vue";
import infocard from "@/components/InformationCard.vue";
export default {
  name: "informationuser",
  components: {
    aboutnav,
    infocard
  }
};
</script>

<style>
.informationusers {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1549732565-d673b928da7f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=749&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-top: 80px;
  padding-bottom: 80px;
}
</style>