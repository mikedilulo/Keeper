<template>
  <div class="informationlegal container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="informationlegalities container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="text-light d-flex justify-content-center mt-5">Keeper Legal</h1>
          <p
            class="text-light d-flex justify-content-center mt-3"
          >Please review the legalities of Keeper below. If any issues arise or are a concern, please reach out to CodeMonkey via the contact page.</p>
        </div>
      </div>
    </div>
    <div class="middle container-fluid">
      <div class="row">
        <div class="col-md-12">
          <legalcard />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import aboutnav from "@/components/AboutNavbar.vue";
import legalcard from "@/components/LegalCard.vue";
export default {
  name: "informationpolicy",
  components: {
    aboutnav,
    legalcard
  }
};
</script>

<style>
.informationlegalities {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1575505586569-646b2ca898fc?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=905&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-top: 80px;
  padding-bottom: 80px;
}
</style>