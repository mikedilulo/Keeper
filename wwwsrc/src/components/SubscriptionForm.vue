<template>
  <div class="subscriptionform">
    <form class="subscription-form" id="myform" method="POST" @submit="sendEmail">
      <label class="mb-2">From:</label>
      <input type="text" name="from_name" placeholder="Enter Email Here" />
      <!-- <input type="text" name="message_html" /> -->
      <br />
      <br />
      <button class="btn btn-success btn-sm" type="submit">Subscribe Today</button>
    </form>
  </div>
</template>

<script>
export default {
  name: "subscriptionform",
  data() {
    return {
      templateParams: {}
    };
  },
  methods: {
    sendEmail(event) {
      // Snippit from Email.js in JQuery
      var myform = $("form#myform");
      event.preventDefault();
      var service_id = "gmail";
      var template_id = "subscription_template";
      myform.find("button").text("Sending...");
      emailjs.sendForm(service_id, template_id, myform[0]).then(
        function() {
          alert("Sent!");
          myform.find("button").text("Send");
        },
        function(err) {
          alert("Send email failed!\r\n Response:\n " + JSON.stringify(err));
          myform.find("button").text("Send");
        }
      );
      return false;
    }
  }
};
</script>

<style>
.subscription-form {
  max-width: 100%;
  background: white;
  padding: 20px 25px;
  margin: auto;
  margin-top: 30px;
  box-shadow: 0px 1px 2px rgba(0, 0, 0, 0.2);
}
.subscription-form input,
form textarea {
  font: inherit;
  padding: 5px 5px;
  width: 100%;
  margin-top: 3px;
  margin-bottom: 15px;
  box-sizing: border-box;
}
.subscription-form button {
  border: 1px solid rgba(0, 0, 0, 0.2);
  padding: 8px 35px;
  font-size: 12px;
  color: white;
}
.subscription-form label {
  color: #777;
  font-size: 11px;
  margin-bottom: 2px;
  display: block;
}
</style>