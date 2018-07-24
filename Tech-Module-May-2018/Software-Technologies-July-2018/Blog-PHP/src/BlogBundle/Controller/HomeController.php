<?php

namespace BlogBundle\Controller;

use BlogBundle\Entity\Post;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;

class HomeController extends Controller {
    /**
     * @Route("/", name="blog_index")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function indexAction() {
        $posts = $this->getDoctrine()->getRepository(Post::class)->findAll();
        
        return $this->render('blog/index.html.twig', ['posts'=>$posts]);
    }
}
