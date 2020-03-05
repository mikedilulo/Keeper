<template>
  <div class="questionskeep container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="questionskeep container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="mt-5 d-flex justify-content-center mb-5">KEEP FREQUENTLY ASKED QUESTIONS(FAQ)</h1>
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I create a keep?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayOneAnswer()">
              <i class="fas fa-caret-down text-success questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divone"
              class="paragraphalign mt-4"
            >After you login to Keeper, You will be prompted with two links in your navbar of where you want to go. When you click on My-Keep-Dashboard, a button will appear called "Create Keep". When you click on this button a modal will appear prompting you to input the information. Make sure you fill out all of the input fields for desired creation of Keep. After you click Create Keep at the bottom of the form, you will see your keep display to the page you are on. Public Keeps will display on the dashboard and home page, while your private keeps will only display in the private keeps page.</p>
          </div>
          <hr class="questionhr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I delete a keep?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwoAnswer()">
              <i class="fas fa-caret-down text-success questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwo"
              class="paragraphalign mt-4"
            >After you have created a keep, you will see it display on the dashboard and home page. If you are in desktop mode, and you hover over the keep with your mouse, it will display buttons. The trash can button in the bottom right corner is the button to delete the keep. Once you delete the keep, be aware you will not get the keep back, and will have to recreate a new keep. In mobile devices when you press the keep with your finger it will display the buttons, when the buttons appear select the trash can and it will remove the keep from your dashboard and home page.</p>
          </div>
          <hr class="questionhr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I make a keep private?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayThreeAnswer()">
              <i class="fas fa-caret-down text-success questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divthree"
              class="paragraphalign mt-4"
            >Prior to creating a keep, you will have the option at the bottom of the form to select whether or not you want the keep to be private. When you make a keep private, it will not display on the home page or dashboard. It will only display in the private keep page of the user. Implemented feature coming soon is you will be able to make the keep public if you so choose. Stay updated with us for more details.</p>
          </div>
          <hr class="questionhr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I add a keep to a vault?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayFourAnswer()">
              <i class="fas fa-caret-down text-success questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divfour"
              class="paragraphalign mt-4"
            >After you have successfully created a keep, and you see it displayed on your home page and dashboard. You have a couple of options. In desktop view you can hover over the keep with your mouse, upon hovering you will see a dropdown menu at the top left of the keep. Click on the dropdown button and it will display a list of vaults you created. In mobile, you will tap the keep with your finger, and the buttons will display. Select the dropdown button in the top left of the keep and it will display a list of vaults that you have created.</p>
          </div>
          <hr class="questionhr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I remove a keep from a vault?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayFiveAnswer()">
              <i class="fas fa-caret-down text-success questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divfive"
              class="paragraphalign mt-4"
            >After you have added a keep successfully to a vault, you will see the keep inside of the vault. When you go to hover over the keep with the mouse, or press the keep (mobile) you will see an extra button that has appeared. This button when clicked will remove the keep from the vault. This will not delete the keep, it will only remove it from the vault. You will still see your keep on the dashboard and home page after performing this action.</p>
          </div>
          <hr class="questionhr" />
        </div>
        <div class="col-md-11 mt-5 d-flex justify-content-between mb-2">
          <div class="col-md-2">
            <p>
              <strong>@Keeper2020</strong>
            </p>
          </div>
          <div class="col-md-8 d-flex justify-content-around">
            <a class="fab fa-facebook-square text-dark" href="https://www.facebook.com"></a>
            <a class="fab fa-twitter-square text-dark" href="https://www.twitter.com"></a>
            <a class="fab fa-linkedin text-dark" href="https://www.linkedin.com"></a>
            <a class="fab fa-github-square text-dark" href="https://www.github.com"></a>
          </div>
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
    displayOneAnswer() {
      var x = document.getElementById("divone");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwoAnswer() {
      var x = document.getElementById("divtwo");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayThreeAnswer() {
      var x = document.getElementById("divthree");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayFourAnswer() {
      var x = document.getElementById("divfour");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayFiveAnswer() {
      var x = document.getElementById("divfive");
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
  border: 1px solid green;
  max-width: 80%;
  margin-right: 15%;
}
</style>