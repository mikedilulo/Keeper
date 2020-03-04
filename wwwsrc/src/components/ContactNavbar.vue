<template>
  <div class="contactnav container-fluid">
    <div class="row">
      <div class="col-md-12 pl-0 pr-0">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
          <a class="navbar-brand mr-4" href="#">
            <router-link :to="{ name: 'login' }">
              <strong class="text-white">KEEPER</strong>
            </router-link>
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
              <router-link :to="{ name: 'informationuser' }" class="nav-link active mr-4">Users</router-link>
              <router-link :to="{ name: 'informationlegal' }" class="nav-link active mr-4">Legal</router-link>
              <router-link :to="{ name: 'informationpolicy' }" class="nav-link active mr-4">Policy</router-link>
              <router-link
                :to="{ name: 'informationhottestkeeps' }"
                class="nav-link active mr-4"
              >Hottest Keeps</router-link>
            </ul>
          </div>
        </nav>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "contactnav"
};
</script>

<style></style>