package com.swing.hito4.Gui.Frame;

import com.swing.hito4.Gui.Panels.DataPanel;
import com.swing.hito4.Gui.Panels.EmptyPanel;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import javax.annotation.PostConstruct;
import javax.swing.*;
import java.awt.*;
@Component
public class MainFrame extends JFrame {
    @Autowired
    private EmptyPanel emptyPanel;
    @Autowired
    private DataPanel dataPanel;

    public MainFrame(){

        this.setTitle("Progra III 2020");
        this.setBounds(300, 200, 800, 500);
        this.setBackground(Color.blue);
        //this.setResizable(false);
        this.setLayout(new GridLayout(2,0));

    }
    @PostConstruct
    public void createPanelsMainFrame(){
        JPanel container = new JPanel();
        container.setLayout(new FlowLayout());
        addPanels(container);
        this.add(container);
        this.setVisible(true);

    }
    public  void addPanels(JPanel container){
        container.add(dataPanel);
        container.add(emptyPanel);
    }
}
