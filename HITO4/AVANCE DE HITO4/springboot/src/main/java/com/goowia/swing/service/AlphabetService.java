package com.goowia.swing.service;

import com.goowia.swing.model.AlphabetModel;
import com.goowia.swing.repository.AlphabetRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class AlphabetService implements AlphabetServiceInterface {
    private static final String Q_P = "Q,W,E,R,T,Y,U,I,O,P";
    private static final String A_L = "A,S,D,F,G,H,J,K,L";
    private static final String Z_M = "Z,X,C,V,B,N,M";
    @Autowired
    private AlphabetRepository alphabetRepository;

    @Override
    public void saveData() {
        if (alphabetRepository.count() == 0) {
            alphabetRepository.save(new AlphabetModel(Q_P, "first"));
            alphabetRepository.save(new AlphabetModel(A_L, "second"));
            alphabetRepository.save(new AlphabetModel(Z_M, "three"));
        }
    }

    @Override
    public List<AlphabetModel> getAllLettersFirst() {
        return alphabetRepository.getFirstRow();
    }

    @Override
    public List<AlphabetModel> getAllLettersSecond() {
        return alphabetRepository.getSecondRow();
    }

    @Override
    public List<AlphabetModel> getAllLettersThree() {
        return alphabetRepository.getThreeRow();
    }
}
