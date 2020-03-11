<template>
  <div class="infocard container-fluid">
    <div class="row">
      <div class="col-md-4 d-flex justify-content-around mb-5 mt-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center">Users Can:</h1>
            <p class="card-text">Create Public Keeps they can share with friends, family and users</p>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mb-5 mt-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center">Users Can:</h1>
            <p
              class="card-text"
            >Create vaults to store all of their created keeps, and keeps shared from other users that were created.</p>
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
            <router-link :to="{name: 'questionsstorage'}">
              <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Storage FAQ</a>
            </router-link>
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
            <router-link :to="{name: 'questionsshare'}">
              <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Shares FAQ</a>
            </router-link>
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
            <router-link :to="{name: 'questionstrending'}">
              <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Trending FAQ</a>
            </router-link>
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
            <router-link :to="{name: 'questionsprivacy'}">
              <a href="#" class="btn btn-dark d-flex justify-content-center">Go To Privacy FAQ</a>
            </router-link>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "infocard"
};
</script>

<style>
.card {
  border: none;
}
</style>