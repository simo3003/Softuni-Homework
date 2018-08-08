# Software-Technologies Exam Cheatsheet

## Make sure you code everything first **before** running the web app! (might cause random bugs otherwise!)

Table of contents:

[JavaScript](#javascript)

[PHP](#php)

[Java](#java)

[C#](#csharp)

## JavaScript

```sh
npm install
```

```sh
npm start
```

### Model

```js
let Cat = sequelize.define("Cat", {
    name: {
        type: Sequelize.TEXT,
    },
    nickname: {
        type: Sequelize.STRING,
    },
    price: {
        type: Sequelize.DOUBLE,
    }
},{
    timestamps:false
});
```

### Index

```js
index: (req, res) => {
        Cat.findAll()
            .then(posts => {
                res.render('home/index', { cat: cat });
            });
    }
```

### Create

GET

```js
createGet: (req, res) => {
    res.render('cat/create')
}
```

POST

```js
createPost: (req, res) => {
    let postArgs = req.body;
    Cat.create(postArgs)
        .then((post) => {
            res.redirect('/');
        })
}
```

### Edit

GET

```js
editGet: (req, res) => {
    let id = req.params.id;
    Cat.findById(id)
        .then(cat => {
            res.render('cat/edit', { cat: cat.dataValues })
        });
}
```

POST

```js
editPost: (req, res) => {
    let args = req.body.cat;
    let id = req.params.id;
    Cat.findById(id)
        .then(cat => {
            cat.updateAttributes(args)
            .then(() => res.redirect('/'));
        });
}
```

### Delete

GET

```js
deleteGet: (req, res) => {
    let id = req.params.id;
    Cat.findById(id)
        .then(cat => res.render('cat/delete', { cat:cat.dataValues }));
}
```

POST

```js
deletePost: (req, res) => {
    let id = req.params.id;
    Cat.findById(id)
        .then(cat => {
            cat.destroy()
            .then(() => res.redirect('/'));
        });
}
```

Rename with the appropriate model!~

## PHP

Use either

```sh
composer install
```

 or

```sh
php composer.phar install
```

for resolving dependencies!

```sh
php bin/console doctrine:database:create --if-not-exists
```


```sh
php bin/console generate:doctrine:entity
```

```sh
php bin/console generate:doctrine:form AppBundle:Cat
```

```php
public function buildForm(FormBuilderInterface $builder, array $options) {
    $builder
    ->add('name', TextType::class)
    ->add('nickname', TextType::class)
    ->add('price', NumberType::class);
}
```

Remember to remove the getBlockPrefix function!

```php
public function getBlockPrefix() {
    return 'appbundle_cat';
}
```

Remember to update the schema after making the entity and form!

```sh
php bin/console doctrine:schema:update --force
```

```sh
php bin/console server:run
```

### Index

```php
/**
 * @Route("/", name="homepage")
 */
public function index(Request $request) {
    $cats = $this
        ->getDoctrine()
        ->getRepository(Cat::class)
        ->findAll();
    return $this->render("cat/index.html.twig", ['cats'=>$cats]);
}
```

### Create

```php
/**
 * @Route("/create", name="create")
 */
public function create(Request $request) {
    $cat = new Cat();
    $form = $this->createForm(CatType::class,$cat);
    $form->handleRequest($request);
    if ($form->isSubmitted()) {
        $em = $this->getDoctrine()->getManager();
        $em->persist($cat);
        $em->flush();
        return $this->redirect('/');
    }
}
```

### Edit

```php
/**
 * @Route("/edit/{id}", name="edit")
 */
public function edit($id, Request $request) {
    $cat = $this->getDoctrine()->getRepository(Cat::class)->find($id);
    $form = $this->createForm(CatType::class,$cat);
    $form->handleRequest($request);
    if ($form->isSubmitted()) {
        $em = $this->getDoctrine()->getManager();
        $em->persist($cat);
        $em->flush();
        return $this->redirect('/');
    }
    return $this->render('cat/edit.html.twig', ['form'=>$form->createView(), 'cat'=>$cat]);
}
```

### Delete

```php
/**
 * @Route("/delete/{id}", name="delete")
 * @param $id
 * @param Request $request
 * @return \Symfony\Component\HttpFoundation\RedirectResponse\Symfony\Component\HttpFoundation\Response
 */
public function delete($id, Request $request) {
    $cat = $this->getDoctrine()->getRepository(Cat::class)->find($id);
    $form = $this->createForm(CatType::class,$cat);
    $form->handleRequest($request);
    if ($form->isSubmitted()) {
        $em = $this->getDoctrine()->getManager();
        $em->remove($cat);
        $em->flush();
        return $this->redirect('/');
    }
    return $this->render('cat/delete.html.twig', ['form'=>$form->createView(), 'cat'=>$cat]);
}
```

 Rename with the appropriate model!~

## Java

Remember to use JDK 1.8 / Java 8, as the skeletons are built on that! (CTRL + SHIFT + ALT + S)

### Model

```java
@Id
@GeneratedValue(strategy = GenerationType.IDENTITY)
private Integer id;

@Column
private String name;

@Column
private String nickname;

@Column
private Double price;
```

### Binding Model

```java
private String name;

private String nickname;

private Double price;
```

Use ALT + INS to generate Getters and Setters (Mutators)!

### Index

```java
@GetMapping("/")
public String index(Model model) {
    List<Cat> cats = catRepository.findAll();
    model.addAttribute("cats", cats);
    model.addAttribute("view", "cat/index");
    return "base-layout";
}
```

### Create

GET

```java
@GetMapping("/create")
public String create(Model model) {
     model.addAttribute("view", "cat/create");
     return "base-layout";
}
```

POST

```java
@PostMapping("/create")
public String createProcess(Model model, CatBindingModel catBindingModel) {
        Cat cat = new Cat();
        cat.setName(catBindingModel.getName());
        cat.setNickname(catBindingModel.getNickname());
        cat.setPrice(catBindingModel.getPrice());
        catRepository.saveAndFlush(cat);
        return "redirect:/";
}
```

### Edit

GET

```java
@GetMapping("/edit/{id}")
public String edit(Model model, @PathVariable int id) {
        Cat cat = catRepository.findOne(id);
        model.addAttribute("cat", cat);
        model.addAttribute("view", "cat/edit");
        return "base-layout";
}

```

POST

```java
@PostMapping("/edit/{id}")
public String editProcess(@PathVariable int id, Model model, CatBindingModel catBindingModel) {
        Cat cat = catRepository.findOne(id);
        cat.setName(catBindingModel.getName());
        cat.setNickname(catBindingModel.getNickname());
        cat.setPrice(catBindingModel.getPrice());
        catRepository.saveAndFlush(cat);
        return "redirect:/";
}
```

### Delete

GET

```java
@GetMapping("/delete/{id}")
public String delete(Model model, @PathVariable int id) {
        Cat cat = catRepository.findOne(id);
        model.addAttribute("cat", cat);
        model.addAttribute("view", "cat/delete");
        return "base-layout";
}
```

POST

```java
@PostMapping("/delete/{id}")
public String deleteProcess(@PathVariable int id, CatBindingModel catBindingModel) {
        Cat cat = catRepository.findOne(id);
        catRepository.delete(cat);
        return "redirect:/";
}
```

Rename with the appropriate model!~

## CSharp

### Model

```cs
[Key]
public int Id { get; set; }

[Required]
public string Name { get; set; }

[Required]
public string Nickname { get; set; }

[Required]
public double Price { get; set; }
```

### Index

```cs
[HttpGet]
[Route("")]
public ActionResult Index()
{
    var cats = context.Cats.ToList();
    return View(cats);
}
```

### Create

GET

```cs
[HttpGet]
[Route("create")]
public ActionResult Create()
{
    return View();
}
```

POST

```cs
[HttpPost]
[Route("create")]
public ActionResult Create(Cat cat)
{
    context.Cats.Add(cat);
    context.SaveChanges();
    return RedirectToAction(nameof(Index));
}
```

### Edit

GET

```cs
[HttpGet]
[Route("edit/{id}")]
public ActionResult Edit(int id)
{
    Cat cat = context
        .Cats
        .FirstOrDefault(p => p.Id == id);
    return View(cat);
}
```

POST

```cs
[HttpPost]
[Route("edit/{id}")]
[ValidateAntiForgeryToken]
public ActionResult EditConfirm(int id, Cat catModel)
{
    context.Cats.Update(catModel);
    context.SaveChanges();
    return RedirectToAction("Index");
}
```

### Delete

GET

```cs
[HttpGet]
[Route("delete/{id}")]
public ActionResult Delete(int id)
{
    Cat cat = context
        .Cats
        .FirstOrDefault(p => p.Id == id);
    return View(cat);
}
```

POST

```cs
[HttpPost]
[Route("delete/{id}")]
[ValidateAntiForgeryToken]
public ActionResult DeleteConfirm(int id, Cat catModel)
{
    context.Cats.Remove(catModel);
    context.SaveChanges();

    return RedirectToAction("Index");
}
```

Rename with the appropriate model!~

Good luck!~
