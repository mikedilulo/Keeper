<template>
  <div class="contact">
    <contactnav />
    <div class="maincontact container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="text-light d-flex justify-content-center mt-5">CONTACT KEEPER</h1>
          <p class="text-light d-flex justify-content-center mt-3">
            While we, at Keeper are good at managing your keeps. There are more
            simple ways to get in contact with us
          </p>
        </div>
      </div>
    </div>
    <div class="middle container-fluid">
      <div class="row">
        <div class="col-md-12">
          <asked />
        </div>
      </div>
    </div>
    <hr />
    <div class="lost container-fluid d-flex justify-content-center">
      <div class="row">
        <div class="col-md-12 mt-5 mb-5">
          <h2>Still Cannot Find What</h2>
          <h2>You Are Looking For?</h2>
          <contactform />
        </div>
      </div>
    </div>
    <hr />
    <div class="footer container-fluid mt-5 mb-3">
      <div class="row">
        <div class="col-md-4 d-flex justify-content-around">
          <h5>Connect With Me</h5>
        </div>
        <div class="col-md-4 d-flex justify-content-around">
          <h5>@2020 Keeper | CodeMonkey1025</h5>
        </div>
        <div class="col-md-4 d-flex justify-content-around">
          <h5>
            <a class="fab fa-github-square mr-4 text-dark" href="https://www.github.com"></a>
            <a class="fab fa-twitter-square mr-4 text-dark" href="https://www.twitter.com"></a>
            <a class="fab fa-facebook-square mr-4 text-dark" href="https://www.facebook.com"></a>
            <a class="fab fa-linkedin-in mr-4 text-dark" href="https://www.linkedin.com"></a>
          </h5>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import contactform from "@/components/ContactForm.vue";
import contactnav from "@/components/ContactNavbar.vue";
import asked from "@/components/AskedCard.vue";
export default {
  name: "contact",
  components: {
    contactnav,
    asked,
    contactform
  }
};
</script>

<style>
.maincontact {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1579275542618-a1dfed5f54ba?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-top: 80px;
  padding-bottom: 80px;
}
hr {
  border: 1px solid black;
}
</style>