<?php

namespace BlogBundle\Controller;

use BlogBundle\Entity\Post;
use BlogBundle\Form\PostType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use Symfony\Component\HttpFoundation\Request;

class PostController extends Controller {
    /**
     * @param Request $request
     * 
     * @Route("/post/create", name="post_create")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     * 
     * @return \Symfony\Component\HttpFoundation\RedirectResponse
     */
    public function create(Request $request)
    {
        $post = new Post();
        $form = $this->createForm(PostType::class, $post);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()){

            $post->setAuthor($this->getUser());
            $em = $this->getDoctrine()->getManager();
            $em->persist($post);
            $em->flush();

            return $this->redirectToRoute('blog_index');
        }

        return $this->render('post/create.html.twig',['form'=>$form->createView()]);
    }

    /**
     * @Route("/post/{id}", name="post_view")
     * @param $id
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function viewPost($id)
    {
        $post = $this->getDoctrine()->getRepository(Post::class)->find($id);

        return $this->render('post/post.html.twig', ['post' => $post]);
    }
}

