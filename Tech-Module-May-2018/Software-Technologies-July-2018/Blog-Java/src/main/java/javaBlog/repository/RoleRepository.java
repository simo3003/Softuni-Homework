package javaBlog.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import javaBlog.entity.Role;

public interface RoleRepository extends JpaRepository<Role, Integer> {
    Role findByName(String name);
}