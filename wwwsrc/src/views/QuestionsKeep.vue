<template>
  <div class="questionskeep container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="questionskeep container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="mt-5 d-flex justify-content-center mb-5">FREQUENTLY ASKED QUESTIONS(FAQ)</h1>
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I create a keep?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divopen"
              class="paragraphalign mt-4"
            >After you login to Keeper, You will be prompted with two links in your navbar of where you want to go. When you click on My-Keep-Dashboard, a button will appear called "Create Keep". When you click on this button a modal will appear prompting you to input the information. Make sure you fill out all of the input fields for desired creation of Keep. After you click Create Keep at the bottom of the form, you will see your keep display to the page you are on. Public Keeps will display on the dashboard and home page, while your private keeps will only display in the private keeps page.</p>
          </div>
          <hr class="questionhr" />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import aboutnav from "@/components/AboutNavbar.vue";
export default {
  name: "questionskeep",
  components: {
    aboutnav
  },
  methods: {
    displayAnswer() {
      var x = document.getElementById("divopen");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    }
  }
};
</script>

<style>
.questiondrop {
  font-size: 30px;
}
.paragraphalign {
  margin-left: 5%;
}
.questionhr {
  border: 1px solid red;
  max-width: 80%;
  margin-right: 15%;
}
</style>