<template>
  <div class="aboutpicture container-fluid passion">
    <i class="fab fa-korvue text-white korvue-logo d-flex justify-content-center mb-5"></i>
    <div class="row">
      <div class="col-md-2 mt-5 mb-5">
        <h5 class="mt-5 text-white">@Keeper 2020</h5>
        <h6 class="mb-5 heading-color">Photo From Unsplash</h6>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "aboutpicture"
};
</script>

<style>
.passion {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1455849318743-b2233052fcff?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-left: 0px;
  margin-right: 0px;
}
.korvue-logo {
  font-size: 300px;
}
.heading-color {
  color: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5));
}
</style>