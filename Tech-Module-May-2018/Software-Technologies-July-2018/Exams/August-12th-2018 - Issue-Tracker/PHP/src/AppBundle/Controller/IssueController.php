<?php

namespace AppBundle\Controller;

use AppBundle\Entity\Issue;
use AppBundle\Form\IssueType;
use AppBundle\Repository\IssueRepository;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class IssueController extends Controller
{
    /**
     * @Route("/", name="homepage")
     */
    public function index(Request $request)
    {
        $issues = $this
        ->getDoctrine()
        ->getRepository(Issue::class)
        ->findAll();
    return $this->render("issue/index.html.twig", ['issues'=>$issues]);
    }

    /**
     * @Route("/create", name="create")
     */
    public function create(Request $request)
    {
        $issue = new Issue();
        $form = $this->createForm(IssueType::class,$issue);
        $form->handleRequest($request);
        if ($form->isSubmitted()) {
            $em = $this->getDoctrine()->getManager();
            $em->persist($issue);
            $em->flush();
            return $this->redirect('/');
        }
        return $this->render("issue/create.html.twig", array('form'=>$form->createView()));
    }

    /**
     * @Route("/edit/{id}", name="edit")
     */

    public function edit($id, Request $request)
    {
        $issue = 
            $this
            ->getDoctrine()
            ->getRepository(Issue::class)
            ->find($id);
        $form = $this->createForm(IssueType::class,$issue);
        $form->handleRequest($request);
        if ($form->isSubmitted()) {
            $em = $this->getDoctrine()->getManager();
            $em->persist($issue);
            $em->flush();
            return $this->redirect('/');
        }
        return $this->render('issue/edit.html.twig', ['form'=>$form->createView(), 'issue'=>$issue]);
    }

    /**
     * @Route("/delete/{id}", name="delete")
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\RedirectResponse|\Symfony\Component\HttpFoundation\Response
     */
    public function delete($id, Request $request)
    {
        $issue = 
            $this
            ->getDoctrine()
            ->getRepository(Issue::class)
            ->find($id);
        $form = $this->createForm(IssueType::class,$issue);
        $form->handleRequest($request);
            if ($form->isSubmitted()) {
            $em = $this->getDoctrine()->getManager();
            $em->remove($issue);
            $em->flush();
            return $this->redirect('/');
        }
        return $this->render('issue/delete.html.twig', ['form'=>$form->createView(), 'issue'=>$issue]);
    
    }
}
