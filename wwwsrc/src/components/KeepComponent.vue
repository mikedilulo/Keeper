<template>
  <div class="keepcomponent container-fluid">
    <div class="row">
      <div class="col-md-2 mb-5 mt-5">
        <div class="card-body p-0 latest-card">
          <div class="d-flex justify-content-between">
            <button type="submit" class="btn btn-dark btn-sm button">
              <i class="fas fa-chevron-circle-down"></i>
            </button>
            <button
              type="submit"
              class="btn btn-dark btn-sm button"
              @click="deleteKeep(keepData.id)"
            >
              <i class="fas fa-trash"></i>
            </button>
          </div>
          <img :src="keepData.img" class="latest-card" alt />
          <dd class="d-flex justify-content-between">
            <router-link :to="{name: 'publicKeepDetails', params: {id: keepData.id}}">
              <button
                type="button"
                class="btn btn-dark btn-sm button"
                @click="setActivePublicKeep(keepData.id)"
                data-dismiss="modal"
              >
                <i class="fas fa-ellipsis-h"></i>
              </button>
            </router-link>
            <button type="submit" class="btn btn-dark btn-sm button">
              <i class="fas fa-share-square"></i>
            </button>
            <button type="submit" class="btn btn-dark btn-sm button">
              <i class="fas fa-pencil-alt"></i>
            </button>
          </dd>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "keepcomponent",
  props: ["keepData"],
  methods: {
    deleteKeep(id) {
      this.$store.dispatch("deletePublicKeep", id);
    },
    setActivePublicKeep(id) {
      this.$store.dispatch("getPublicKeepById", id);
    }
  }
};
</script>

<style>
.latest-card {
  border-radius: 10px;
  max-width: 100%;
  max-height: 100%;
}
.button {
  display: none;
  z-index: 1;
}
.latest-card:hover .button {
  display: block;
}
.dropdown {
  position: absolute;
}
#dropdownMenuButton {
  min-width: 90%;
  min-height: 100%;
}
.dropdown {
  display: none;
}
.latest-card:hover .dropdown {
  display: block;
}
.card-body {
  min-height: 100%;
}
.dropbtn,
.sub-dropbtn {
  background-color: transparent;
  cursor: pointer;
  border: none;
}
</style>