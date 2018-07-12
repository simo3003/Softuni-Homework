# handlebars-helper-selectif

A Handlebars helper for selecting an option in a dropdown input field, based on an equality check

Idea and template is from [this helper module](https://github.com/zeke/handlebars-helper-equal)

## Installation

Download node at [nodejs.org](http://nodejs.org) and install it, if you haven't already.

```sh
npm install handlebars-helper-selectif --save
```

## Usage

In your JavaScript file:

```js
var express = require("express")
var hbs = require("hbs")
hbs.registerHelper("equal", require("handlebars-helper-selectif"))
var app = express()
app.set("view engine", "hbs")
// etc...
```

In your Handlebars template:

```hbs
{{ selectif option value }}
```

## Tests

```sh
npm install
```
