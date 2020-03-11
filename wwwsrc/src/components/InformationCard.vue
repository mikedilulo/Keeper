<template>
  <div class="infocard container-fluid">
    <div class="row">
      <div class="col-md-4 d-flex justify-content-around mb-5 mt-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center text-danger">Users Can:</h1>
            <strong>
              <p class="card-text">Create Public Keeps they can share with friends, family and users</p>
            </strong>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mb-5 mt-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center text-danger">Users Can:</h1>
            <strong>
              <p
                class="card-text"
              >Create vaults to store all of their created keeps, and keeps shared from other users that were created.</p>
            </strong>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mb-5 mt-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center text-danger">Users Can:</h1>
            <strong>
              <p
                class="card-text"
              >View the keep details of who it was created by, what ID the keep is, and how many times the keep has been viewed by other people.</p>
            </strong>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mt-5 mb-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center text-danger">Users Can:</h1>
            <strong>
              <p
                class="card-text"
              >Secure their keeps within vaults. This allows you to keep them safe if they get deleted by the original user</p>
            </strong>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mt-5 mb-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center text-danger">Users Can:</h1>
            <strong>
              <p
                class="card-text"
              >Subscribe to Keeper to recieve monthly updates, and newsletters. This will include trending keeps, along with other information.</p>
            </strong>
          </div>
        </div>
      </div>
      <div class="col-md-4 d-flex justify-content-around mt-5 mb-5">
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <h1 class="card-title d-flex justify-content-center text-danger">Users Can:</h1>
            <strong>
              <p
                class="card-text"
              >Create Private Keeps that only you the creator can view. Nobody will have access to these keeps.</p>
            </strong>
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