<template>
  <div class="loginbar">
    <div class="row">
      <div class="col-md-12 p-0">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
          <a class="navbar-brand logo headings" href="#">
            <i class="fab fa-korvue logo headings"></i>
            <router-link :to="{name: 'login'}" class="text-dark">Keeper</router-link>
          </a>
          <button
            class="navbar-toggler"
            type="button"
            data-toggle="collapse"
            data-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav ml-auto">
              <li class="nav-item active lists">
                <router-link
                  :to="{ name: 'suggestion' }"
                  class="nav-link mr-4 headings"
                >Suggestion Vault</router-link>
              </li>
              <li class="nav-item active lists">
                <router-link
                  :to="{ name: 'subscribe' }"
                  class="nav-link mr-4 headings"
                >Keeper Subscription</router-link>
              </li>
              <li class="nav-item active lists">
                <router-link :to="{ name: 'about' }" class="nav-link mr-4 headings">About Keeper</router-link>
              </li>
              <li class="nav-item active lists">
                <router-link :to="{ name: 'contact' }" class="nav-link mr-4 headings">Contact Keeper</router-link>
              </li>
            </ul>
          </div>
        </nav>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "loginbar"
};
</script>

<style>
.lists {
  font-size: 17px;
}
.headings {
  color: black;
  font-weight: bold;
}
</style>