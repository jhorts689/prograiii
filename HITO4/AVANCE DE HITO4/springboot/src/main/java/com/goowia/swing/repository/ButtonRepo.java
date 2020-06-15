package com.goowia.swing.repository;

import com.goowia.swing.model.ButtonModel;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

@Repository
public interface ButtonRepo extends JpaRepository<ButtonModel, Integer> {
    @Query(value = "SELECT * FROM button ORDER BY random() LIMIT 1", nativeQuery = true)
    public ButtonModel getTitleButton();
}
