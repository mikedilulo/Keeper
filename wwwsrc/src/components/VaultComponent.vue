<template>
  <div class="vault-component container-fluid">
    <div class="row">
      <div class="col-md-2">
        <div class="card vault-card mt-3" style="width: 18rem;">
          <img :src="vaultData.img" class="card-img-top" alt="..." />
          <div class="card-body">
            <h5 class="card-title">{{vaultData.name}}</h5>
            <p class="card-text">{{vaultData.description}}</p>
            <div class="d-flex justify-content-between">
              <router-link :to="{name: 'vaultdetails', params: {id: vaultData.id}}">
                <button type="button" class="btn btn-dark btn-sm">
                  <i class="fas fa-eye"></i>
                </button>
              </router-link>
              <button class="btn btn-dark btn-sm" @click="deleteVault(vaultData.id)">
                <i class="fas fa-trash"></i>
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "vaultComponent",
  props: ["vaultData"],
  methods: {
    deleteVault(id) {
      this.$store.dispatch("deleteVault", id);
    }
  }
};
</script>

<style>
.card {
  border: 1px solid black;
}
</style>