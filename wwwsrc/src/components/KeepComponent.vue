<template>
  <div class="keepcomponent container-fluid">
    <div class="row">
      <div class="col-md-2 mb-5 mt-5">
        <div class="latest-card">
          <div class="dropdown">
            <button
              class="btn btn-light dropdown-toggle d-flex justify-content-end ml-1"
              type="button"
              id="dropdownMenuButton"
              data-toggle="dropdown"
              aria-haspopup="true"
              aria-expanded="false"
            ></button>
            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
              <div>
                <button class="dropdown-item"></button>
              </div>
            </div>
          </div>
          <div class="card-body p-0">
            <img :src="keepData.img" class="latest-card image" alt />
            <dd class="d-flex justify-content-between">
              <button
                class="btn btn-light btn-sm button"
                type="button"
                data-toggle="modal"
                data-target="#shareModal"
              >
                <i class="fas fa-share-square"></i>
              </button>
              <button
                class="btn btn-light btn-sm button"
                type="button"
                data-toggle="modal"
                data-target="#informationModal"
              >
                <i class="fas fa-ellipsis-h"></i>
              </button>
            </dd>
          </div>
        </div>
      </div>
    </div>
    <!-- Information Modal -->
    <div
      class="modal fade"
      id="informationModal"
      tabindex="-1"
      role="dialog"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Keep Information</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <h4>
              <i class="fab fa-korvue mr-1"></i>:
              <span>0</span>
            </h4>
            <h4>
              <i class="fas fa-share-square mr-1"></i>:
              <span>0</span>
            </h4>
            <h4>
              <i class="fas fa-eye mr-1"></i>:
              <span>0</span>
            </h4>
            <div class="modal-footer">
              <button
                type="submit"
                class="btn btn-warning mr-auto"
                data-dismiss="modal"
                @click="deleteKeep(keepData.id)"
              >Delete</button>
              <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- Share Modal -->
    <div
      class="modal fade"
      id="shareModal"
      tabindex="-1"
      role="dialog"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Share Your Keep</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <form>
              <div class="form-group">
                <label for="recipient-name" class="col-form-label">Recipient:</label>
                <input
                  type="text"
                  class="form-control"
                  id="recipient-name"
                  placeholder="Type Email Here"
                />
              </div>
              <button type="button" class="btn btn-success">Send Keep</button>
            </form>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
          </div>
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
      this.$store.dispatch("deleteKeep", id);
    }
  }
};
</script>

<style>
.latest-card {
  border-radius: 10px;
  max-width: 100%;
  max-height: 100%;
  position: relative;
}
.button {
  display: none;
}
.latest-card:hover .button {
  display: block;
  z-index: 1;
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
.image {
  z-index: -1;
  max-width: 100%;
  max-height: 100%;
  position: relative;
}
</style>