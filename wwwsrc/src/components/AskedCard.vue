<template>
  <div class="asked container-fluid">
    <div class="row">
      <div class="col-md-4 d-flex justify-content-around mb-5 mt-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center">
              <i class="fas fa-pager"></i>
            </h1>
            <p class="card-text">Click the button below to navigate to the Keep FAQ</p>
            <router-link :to="{name: 'questionskeep'}">
              <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Keep FAQ</a>
            </router-link>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mb-5 mt-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center">
              <i class="fas fa-box"></i>
            </h1>
            <p class="card-text">Click the button below to navigate to the Vault FAQ</p>
            <router-link :to="{name: 'questionsvault'}">
              <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Vault FAQ</a>
            </router-link>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mb-5 mt-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center">
              <i class="fas fa-warehouse"></i>
            </h1>
            <p class="card-text">Click the button below to navigate to the Storage FAQ</p>
            <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Storage FAQ</a>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mt-5 mb-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center">
              <i class="fas fa-share-square"></i>
            </h1>
            <p class="card-text">Click the button below to navigate to the Shares FAQ</p>
            <a href="#" class="btn btn-dark d-flex justify-content-center">Go Shares FAQ</a>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mt-5 mb-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center">
              <i class="fas fa-fire"></i>
            </h1>
            <p class="card-text">Click the button below to navigate to the Trending FAQ</p>
            <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Trending FAQ</a>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mt-5 mb-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center">
              <i class="fas fa-user-secret"></i>
            </h1>
            <p class="card-text">Click the button below to navigate to the Privacy FAQ</p>
            <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Privacy FAQ</a>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "asked"
};
</script>

<style>
.card {
  border: none;
}
</style>