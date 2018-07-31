package javaBlog.controller;

import javaBlog.bindingModel.PostBindingModel;
import javaBlog.entity.Post;
import javaBlog.entity.User;
import javaBlog.repository.PostRepository;
import javaBlog.repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class PostController {
    @Autowired
    private PostRepository postRepository;
    @Autowired
    private UserRepository userRepository;
    @GetMapping("/post/create")
    @PreAuthorize("isAuthenticated()")
    public String create(Model model) {
        model.addAttribute("view", "post/create");
        return "base-layout";
    }
    @PostMapping("/post/create")
    @PreAuthorize("isAuthenticated()")
    public String createProcess(PostBindingModel postBindingModel) {
        UserDetails user = (UserDetails) SecurityContextHolder
                .getContext()
                .getAuthentication()
                .getPrincipal();
        User userEntity = this.userRepository.findByEmail(user.getUsername());

        Post postEntity = new Post(
                postBindingModel.getTitle(),
                postBindingModel.getContent(),
                userEntity
        );

        this.postRepository.saveAndFlush(postEntity);

        return "redirect:/";
    }
    @GetMapping("/post/{id}")
    public String details(Model model, @PathVariable Integer id) {
        if(!this.postRepository.exists(id)) {
            return "redirect:/";
        }

        Post post = this.postRepository.findOne(id);

        model.addAttribute("post", post);
        model.addAttribute("view", "post/details");

        return "base-layout";
    }
    @GetMapping("/post/edit/{id}")
    @PreAuthorize("isAuthenticated()")
    public String edit(Model model, @PathVariable Integer id) {
        if(!this.postRepository.exists(id)) {
            return "redirect:/";
        }
        Post post = this.postRepository.findOne(id);

        model.addAttribute("post", post);
        model.addAttribute("view", "post/edit");

        return "base-layout";
    }
    @PostMapping("/post/edit/{id}")
    @PreAuthorize("isAuthenticated()")
    public String editProcess(@PathVariable Integer id, PostBindingModel postBindingModel) {
        if(!this.postRepository.exists(id)) {
            return "redirect:/";
        }
        Post post = this.postRepository.findOne(id);

        post.setContent(postBindingModel.getContent());
        post.setTitle(postBindingModel.getTitle());

        this.postRepository.saveAndFlush(post);

        return "redirect:/post/" + post.getId();
    }
    @GetMapping("/post/delete/{id}")
    @PreAuthorize("isAuthenticated()")
    public String delete(Model model, @PathVariable Integer id) {
        if(!this.postRepository.exists(id)) {
            return "redirect:/";
        }
        Post post = this.postRepository.findOne(id);

        model.addAttribute("post", post);
        model.addAttribute("view", "post/delete");

        return "base-layout";
    }

    @PostMapping("/post/delete/{id}")
    @PreAuthorize("isAuthenticated()")
    public String deleteProcess(@PathVariable Integer id, PostBindingModel postBindingModel) {
        if(!this.postRepository.exists(id)) {
            return "redirect:/";
        }
        Post post = this.postRepository.findOne(id);

        this.postRepository.delete(post);

        return "redirect:/";
    }
}
