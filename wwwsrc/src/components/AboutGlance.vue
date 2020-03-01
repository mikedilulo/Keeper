<template>
  <div class="glance">
    <div class="about-glance container-fluid">
      <div class="row">
        <div class="col-md-2 order-md-2 mt-5 glances">
          <p class="decoration">Keeper At A Glance</p>
          <h5 class="mt-4">FOUNDED</h5>
          <p>February 2020</p>
          <h5>CEO</h5>
          <p>Code Monkey</p>
          <h5>HEADQUARTERS</h5>
          <p>Boise, Idaho</p>
        </div>
        <div class="col-md-2 order-md-3 mt-5">
          <p class="decoration">Up To Date Information</p>
          <h5 class="mt-4">Keeps Created Today</h5>
          <p>2500</p>
          <h5>Languages</h5>
          <p>2</p>
        </div>
        <div class="col-md-4 order-md-1 mt-5 mb-5">
          <i class="fab fa-korvue info-icon"></i>
        </div>
      </div>
    </div>
    <hr />
  </div>
</template>

<script>
export default {
  name: "glance"
};
</script>

<style>
.glances {
  border-right: 1px solid grey;
}
</style>