<template>
  <div class="keepdetailnav container-fluid">
    <div class="row">
      <div class="col-md-12 pl-0 pr-0">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
          <router-link :to="{ name: 'dashboard' }">
            <a class="navbar-brand logo headings" href="#">
              <i class="fab fa-korvue logo headings"></i>
              <router-link :to="{name: 'dashboard'}" class="text-dark">Keeper</router-link>
            </a>
          </router-link>
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
            <ul class="navbar-nav mr-auto"></ul>
            <form class="form-inline my-2 my-lg-0">
              <input
                class="form-control mr-sm-2"
                type="search"
                placeholder="Search Keeper..."
                aria-label="Search"
              />
              <button class="btn btn-outline-dark my-2 my-sm-0" type="submit">Search</button>
            </form>
          </div>
        </nav>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "keepdetailnav"
};
</script>

<style>
.about-nav {
  font-size: 28px;
}
.headings {
  color: black;
  font-weight: bold;
}
</style>