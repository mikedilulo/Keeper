<template>
  <div class="about">
    <aboutnav />
    <aboutpicture />
    <aboutcount />
    <hr />
    <aboutinfo />
    <hr />
    <glance />
    <div class="latest-keeps container-fluid">
      <div class="row">
        <div class="col-md-10 mt-5">
          <h4>OUR LATEST KEEPS</h4>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import aboutnav from "@/components/AboutNavbar.vue";
import aboutpicture from "@/components/AboutPicture.vue";
import aboutcount from "@/components/AboutCountCard.vue";
import aboutinfo from "@/components/AboutInfo.vue";
import glance from "@/components/AboutGlance.vue";
export default {
  name: "about",
  components: {
    aboutnav,
    aboutpicture,
    aboutcount,
    aboutinfo,
    glance
  }
};
</script>

<style>
.numbers-about {
  font-size: 50px;
}
.number-cards {
  border-right: 1px solid grey;
}
/* .glance {
  border-right: 1px solid grey;
} */
.decoration {
  text-decoration: underline;
  margin-bottom: 2px;
}
.info-icon {
  font-size: 300px;
}
</style>