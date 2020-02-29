<template>
  <div class="login background-image">
    <div class="main container-fluid">
      <loginbar />
    </div>
    <div class="body container-fluid">
      <div class="row">
        <div class="col text-light d-flex justify-content-center wording">
          <div class="text-light">
            <p>A Way To Collect</p>
            <p>And Share Your Keeps</p>
            <p>With Everybody</p>
            <div>
              <button class="btn btn-primary ml-2 mr-5" @click="login">Login to Keeper</button>
              <button class="btn btn-success ml-2" @click="login">Keeper Register</button>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="footer container-fluid">
      <div class="row">
        <div class="col-md-12 d-md-block d-none d-flex justify-content-end footer-login">
          <p class="text-light">@2020 Keeper | Design By CodeMonkey1025</p>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import loginbar from "@/components/LoginNavbar.vue";
import axios from "axios";
let _api = axios.create({
  baseURL: "https://localhost:5001",
  withCredentials: true
});
export default {
  name: "Login",
  methods: {
    async login() {
      await this.$auth.loginWithPopup();
      this.$store.dispatch("setBearer", this.$auth.bearer);
      this.$router.push({ name: "home" });
      console.log(this.$auth.user);
    }
  },
  components: {
    loginbar
  }
};
</script>

<style>
.logo {
  font-size: 26px;
  margin-right: 10px;
}
.background-image {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)),
    url("https://images.unsplash.com/photo-1565126035964-29e1c95b13f9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80");
  background-size: cover;
  background-repeat: no-repeat;
  max-width: 100%;
  height: 100%;
  padding-left: 0px;
  margin-right: 0px;
}
.wording {
  margin-top: 100px;
  font-size: 50px;
}
.footer-login {
  margin-top: 110px;
}
</style>