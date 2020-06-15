package com.goowia.swing.model;

import javax.persistence.*;

@Entity
@Table (name = "Button")
public class ButtonModel {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer Id;

    @Column(name = "title", length = 50, nullable = false)
    private String titleButton;

    public ButtonModel() {

    }

    public ButtonModel(String titleButton) {
        this.titleButton = titleButton;
    }

    public Integer getId() {
        return Id;
    }

    public void setId(Integer id) {
        Id = id;
    }

    public String getTitleButton() {
        return titleButton;
    }

    public void setTitleButton(String titleButton) {
        this.titleButton = titleButton;
    }
}
