<template>
  <div class="vault-component container-fluid">
    <div class="row">
      <div class="col-md-2">
        <div class="card" style="width: 18rem;">
          <img
            src="https://images.unsplash.com/photo-1462045504115-6c1d931f07d1?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=751&q=80"
            class="card-img-top"
            alt="..."
          />
          <div class="card-body">
            <h5 class="card-title">Card title</h5>
            <p
              class="card-text"
            >Some quick example text to build on the card title and make up the bulk of the card's content.</p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "vaultComponent",
  props: ["vaultData"]
};
</script>

<style>
</style>