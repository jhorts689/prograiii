package com.swing.hito4.model;

import javax.persistence.*;

@Entity
@Table(name = "Alphabet")
public class Datamodel {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer Id;

    @Column(name = "letter", length = 200, nullable = false)
    private String letter;

    @Column(name = "types", length = 10, nullable = false)
    private String types;


    public Datamodel() {

    }

    public Datamodel(String letter, String types) {
        this.letter = letter;
        this.types = types;
    }

    public String getTypeR() {
        return types;
    }

    public void setTypeR(String types) {
        this.types = types;
    }

    public Integer getId() {
        return Id;
    }

    public void setId(Integer id) {
        Id = id;
    }

    public String getLetter() {
        return letter;
    }

    public void setLetter(String letter) {
        this.letter = letter;
    }
}
