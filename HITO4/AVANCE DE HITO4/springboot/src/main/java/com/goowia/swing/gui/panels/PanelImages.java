package com.goowia.swing.gui.panels;

import com.goowia.swing.gui.util.Util;
import org.springframework.stereotype.Component;

import javax.annotation.PostConstruct;
import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;

@Component
public class PanelImages extends JPanel {
    public PanelImages() {
        this.setPreferredSize(new Dimension(600, 190));
        this.setBackground(Color.WHITE);
        this.setLayout(new GridLayout(1, 5));
    }

    @PostConstruct
    public void createPanelImages() {
        JPanel imagePanel = new JPanel();
        imagePanel.setLayout(new FlowLayout());

        for(int i=0; i<5; i++) {
            JLabel label = new JLabel(getImageIcon(Util.FAILED_IMAGE.getImage()));
            imagePanel.add(label);
        }

        this.add(imagePanel);
    }

    public ImageIcon getImageIcon(Image src) {
        int width = 100;
        int height = 60;
        int type = BufferedImage.TYPE_INT_RGB;

        BufferedImage dst = new BufferedImage(width, height, type);
        Graphics2D g2 = dst.createGraphics();
        g2.drawImage(src, 0, 0, width, height, this);
        g2.dispose();

        return new ImageIcon(dst);
    }
}
