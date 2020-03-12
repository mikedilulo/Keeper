<template>
  <div class="informationhottestkeeps container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="informationhot container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="text-light d-flex justify-content-center mt-5">Keeper Hottest Keeps</h1>
          <p
            class="text-light d-flex justify-content-center mt-3"
          >Is your keep trending? If so, take a look down below at some of the cards that can give you answers. Having keeps trend is a great thing, so why not make it happen all the time?</p>
        </div>
      </div>
    </div>
    <div class="middle container-fluid">
      <div class="row">
        <div class="col-md-12">
          <hottestcard />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import aboutnav from "@/components/AboutNavbar.vue";
import hottestcard from "@/components/HottestKeepCard.vue";
export default {
  name: "informationhottestkeeps",
  components: {
    aboutnav,
    hottestcard
  }
};
</script>

<style>
.informationhot {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1556960653-9f195e88c52e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=667&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-top: 80px;
  padding-bottom: 80px;
}
</style>