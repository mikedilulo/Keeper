<template>
  <div class="questionstrending container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="questionstrending container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1
            class="mt-5 d-flex justify-content-center mb-5"
          >TRENDING FREQUENTLY ASKED QUESTIONS(FAQ)</h1>
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I create a vault?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentysixAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentysix"
              class="paragraphalign mt-4"
            >After you login to Keeper, You will be prompted with two links in your navbar of where you want to go. When you click on My-Keep-Dashboard, a button will appear that is called "My Vaults". When you click on this button a modal will appear prompting you to input the information. Make sure you fill out all of the input fields for desired creation of a Vault. After you click Create Vault at the bottom of the form, you will see your vault display to the page you are on. Vaults will only will display on the My-Vaults page.</p>
          </div>
          <hr class="trendinghr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I delete a vault?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentysevenAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentyseven"
              class="paragraphalign mt-4"
            >After you have created a vault, you will see it display on the My-Vaults page. At the bottom of the vault underneath the description will be two buttons. One to view the keeps inside of the vault and the other to delete it. Once you delete the vault, be aware you will not get the vault back, and will have to recreate a new vault. The vaults you create are only private to you.</p>
          </div>
          <hr class="trendinghr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>What happens to my keeps inside if I delete a vault?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentyeightAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentyeight"
              class="paragraphalign mt-4"
            >If your keeps are public when you first created them, you will be able to still see all of your keeps on the dashboard and home page. If your keeps are private when created, you will still be able to view them in the Private-Keeps Page of the user who is logged in. If you have a keep shared from somebody, and it is in the vault, it will be removed unless it is saved on another page in your dashboard.</p>
          </div>
          <hr class="trendinghr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Is there a default img if I dont have one?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentynineAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentynine"
              class="paragraphalign mt-4"
            >When you first go to create a vault, you will be prompted with four input fields. Please ensure that you input all of the fields correctly so it can be displayed on the vault. If your URL is too long than it will not work, you will have to find a shorter URL to input in the form and have it create the vault. Currently there is no way to have a default picture, you will need to input one if you want to have it tailored to your likes.</p>
          </div>
          <hr class="trendinghr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>What is the vault view?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayThirtyAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divthirty"
              class="paragraphalign mt-4"
            >This is just a simple tracker to let you know how many times you have looked inside of the vault at the keeps. This count will go up when you click the details button at the bottom left of the keep. It can keep track over time, and with an implemented upcoming feature it will display your top viewed vaults so its easier for you as the user to navigate to the keeps you really want to look at.</p>
          </div>
          <hr class="trendinghr" />
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
  name: "questionstrending",
  components: {
    aboutnav
  },
  methods: {
    displayTwentysixAnswer() {
      var x = document.getElementById("divtwentysix");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentysevenAnswer() {
      var x = document.getElementById("divtwentyseven");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentyeightAnswer() {
      var x = document.getElementById("divtwentyeight");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentynineAnswer() {
      var x = document.getElementById("divtwentynine");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayThirtyAnswer() {
      var x = document.getElementById("divthirty");
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
.trendinghr {
  border: 1px solid red;
  max-width: 80%;
  margin-right: 15%;
}
</style>